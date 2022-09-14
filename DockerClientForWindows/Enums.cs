using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerClientForWindows
{
    internal class Enums
    {
    }

    public enum ContainerState
    {
        created,
        restarting,
        running,
        paused,
        exited,
        dead
    }
}
