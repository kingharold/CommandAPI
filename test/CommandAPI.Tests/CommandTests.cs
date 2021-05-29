using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Base Platform",
                CommandLine = "Some command"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            
            // Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }
        [Fact]
        public void CanChangePlatform()
        {
            
            testCommand.Platform = "OSX";
            Assert.Equal("OSX", testCommand.Platform);
        }
        [Fact]
        public void CanChangeCommandLine()
        {
            
            testCommand.CommandLine = "run it";
            Assert.Equal("run it", testCommand.CommandLine);
        }
    }
}