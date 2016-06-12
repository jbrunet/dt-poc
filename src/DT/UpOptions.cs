using CommandLine;

namespace DT
{
    [Verb("up")]
    public class UpOptions
    {
        [Option('c', "config-file", HelpText = "DT configuration file", Default = "config.yml")]
        public string ConfigFile { get; set; }
    }
}
