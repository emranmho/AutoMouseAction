using AutoMove.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMove.Commands
{
    public class StopCommand : IMoveCommand
    {
        private readonly MouseMoverService _mouseMoverService;

        public StopCommand(MouseMoverService mouseMoverService)
        {
            _mouseMoverService = mouseMoverService;
        }

        public void Execute()
        {
            _mouseMoverService.Stop();
        }
    }
}
