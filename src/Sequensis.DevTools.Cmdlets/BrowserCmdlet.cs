using System.Diagnostics;
using System.Management.Automation;

namespace Sequensis.DevTools.Cmdlets
{
    [Cmdlet("Start", "Browser")]
    public class BrowserCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Position = 0, HelpMessage = "Site to browse")]
        [ValidateNotNullOrEmpty]
        public string Site { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject("\n");
            WriteObject("OPENING: " + Site);

            Process.Start("http://google.com");
        }
    }
}
