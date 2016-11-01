using System.Management.Automation;

namespace Sequensis.DevTools.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "Deploy")]
    public class NewDeployCmdlet : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0,
            HelpMessage = "Deploy stuff."
            )]
        [Alias("Person", "FirstName")]
        public string[] ComponentCollection { get; set; }

        protected override void ProcessRecord()
        {
            foreach (var component in ComponentCollection)
            {
                WriteVerbose("Creating a deployment for "+ component);
                var deployment = "Deploying: " + component;
                WriteObject(component);
            }
        }
    }
}
