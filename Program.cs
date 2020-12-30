using System;
using Microsoft.Extensions.CommandLineUtils;

namespace my_git
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "my-git";
            app.Description = "Distributed Version Control System.";
            app.HelpOption("-h|--help");
            app.Execute(args);
        }
    }
}
