
using CreationalPatterns.Creational.Builder;
using CreationalPatterns.Creational.Builder.Hardware;
using Xunit;

namespace TestCreationalPatterns.Creational.Builder
{
    public class HardwareBuilderTest
    {
        [Fact]
        public void BuildDesktop()
        {
            DesktopBuilder builder = new DesktopBuilder();
            HardwareDirector director = new HardwareDirector(builder);
            director.Assemble();
            Machine desk = builder.Build();
            Assert.Equal(300, desk.Components.HD);
            Assert.Equal(16, desk.Components.RAM);

        }

        [Fact]
        public void BuildGameConsole()
        {
            GameConsoleBuilder builder = new GameConsoleBuilder();
            HardwareDirector director = new HardwareDirector(builder);
            director.Assemble();
            Machine console = builder.Build();
            Assert.Equal(300, console.Components.HD);
            Assert.Equal(16, console.Components.RAM);
        }
    }
}
