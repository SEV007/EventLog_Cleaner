using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EventLogCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opt1_Click(object sender, EventArgs e)
        {
            cmdOutput.Text = "";
            wevtutil_el(); //Enumerate and clean the events from the logs
            cleanLeftovers(); //Enumerate and clean common events from logs and leftovers
            cmdOutput.Text = "LOGS CLEANED SUCCESSFULLY";
        }

        private void opt5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CLEANS WINDOWS DRIVE
        private void opt33_Click(object sender, EventArgs e)
        {
            cmdOutput.Text = "";
            string cmdCommand = "cleanmgr /D %SYSTEMDRIVE%";
            executeCommand(cmdCommand);
            cmdOutput.Text = "WINDOWS DRIVE IS CLEAN";
        }

        //AUXILIAR COMMAND EXECUTION METHOD
        static void executeCommand(string cmdCommand)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";

            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;

            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Close();
            //cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        //ONLY COMMON LOGS CLEANER
        private void cleanLeftovers()
        {
            progressLeftovers();
            progressBar1.Value = 0;

            var logList = EventLog.GetEventLogs();
            foreach(EventLog e in logList)
            {
                progressBar1.Value += 1;
                e.Clear();
            }
        }

        //SPECIAL AND COMMON LOGS CLEANER
        private void wevtutil_el()
        {
            progressMax();
            progressBar1.Value = 0;

            var output = "";
            var p = new Process();
            var psi = new ProcessStartInfo("wevtutil.exe", "el");

            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            p.StartInfo = psi;
            p.Start();

            using (var processOutput = p.StandardOutput)
            {
                output = processOutput.ReadToEnd();
            }

            p.WaitForExit();

            var eventLogs = output
                .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var item in eventLogs)
            {
                //Console.WriteLine(item);
                progressBar1.Value += 1;
                
                var pt = new Process();
                ProcessStartInfo pit = new ProcessStartInfo("wevtutil", "cl "+item);
                pit.CreateNoWindow = true;
                pit.RedirectStandardOutput = true;
                pit.UseShellExecute = false;
                pt.StartInfo = pit;
                pt.Start();
            }
        }

        //CPU LIMITER
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 0;

            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;

            int pAux = progressBar2.Value;

            if(progressBar2.Value <= numericUpDown1.Value)
            {
                progressBar2.Value += 5;
            }
            else
            {
                progressBar2.Value -= 5;
            }

            int cpu = (int)numericUpDown1.Value;

            string cmdCommand = "";
            cmdCommand = "powercfg -setacvalueindex SCHEME_CURRENT SUB_PROCESSOR PROCTHROTTLEMAX " + cpu;
            executeCommand(cmdCommand);
            cmdCommand = "powercfg -setdcvalueindex SCHEME_CURRENT SUB_PROCESSOR PROCTHROTTLEMAX " + cpu;
            executeCommand(cmdCommand);
            cmdCommand = "powercfg.exe -setactive SCHEME_CURRENT";
            executeCommand(cmdCommand);
            cmdOutput.Text = "CPU Limit set to " + cpu.ToString() + "%";
            cmdOutput.Text += "\r\nThe recomended CPU limit is 70% to 95% to prevent overheating especially in laptops";
        }

        //PROGRESS BARS MAXIMUM COUNTERS
        private void progressMax()
        {
            int c = 0;
            var output = "";
            var p = new Process();
            var psi = new ProcessStartInfo("wevtutil.exe", "el");

            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            p.StartInfo = psi;
            p.Start();

            using (var processOutput = p.StandardOutput)
            {
                output = processOutput.ReadToEnd();
            }

            p.WaitForExit();

            var eventLogs = output
                .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            ProcessStartInfo startInfo = new ProcessStartInfo("argsecho.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            foreach (var item in eventLogs)
            {
                c+=1;
            }
            progressBar1.Maximum = c;

        }

        private void progressLeftovers()
        {
            int l = 0;
            var logList = EventLog.GetEventLogs();
            foreach (EventLog e in logList)
            {
                l+=1;
            }
            progressBar1.Maximum = l;
        }

    }
}
