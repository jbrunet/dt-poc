using System.IO;
using System.Collections.Generic;
using CommandLine;
using YamlDotNet.RepresentationModel;
using System;
using System.Linq;

namespace DT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<UpOptions>(args)
                .WithParsed(Up)
                .WithNotParsed(Error);
        }

        private static Config LoadConfig(string configFile)
        {
            var config = new Config();
            using (var sr = File.OpenText(configFile))
            {
                var yaml = new YamlStream();
                yaml.Load(sr);
                var doc = yaml.Documents.First();
                var root = doc.RootNode;
            }
            return config;
        }

        private static void Up(UpOptions options)
        {
            var config = LoadConfig(options.ConfigFile);
        }

        private static void Error(IEnumerable<Error> errors)
        {
        }
    }
}
