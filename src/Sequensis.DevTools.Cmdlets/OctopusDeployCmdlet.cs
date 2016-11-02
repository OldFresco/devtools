using System;
using System.Diagnostics;
using System.Management.Automation;

namespace Sequensis.DevTools.Cmdlets
{
    [Cmdlet("Start", "Deploy")]
    public class OctopusDeployCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Position = 0, HelpMessage = "Specify which component to deploy")]
        [ValidateNotNullOrEmpty]
        public string ComponentName { get; set; }
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Position = 1, HelpMessage = "Specify which environment to deploy component to")]
        [ValidateNotNullOrEmpty]
        public string Environment { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject("\n");
            WriteObject("DEPLOYING: " + ComponentName);
            WriteObject("ON ENVIRONMENT: " + Environment);
            WriteObject("\nThat cool? If not, CTRL+C to cancel otherwise press ENTER");

            InvokeCommand.InvokeScript("Read-Host");

            const string args = "/C octo list-projects --server {server} --apiKey API-{key}";
            Process.Start("CMD.exe", args);
        }
    }
}
