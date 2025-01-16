using AutoMove.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMove.Commands
{
    public class StartCommand : IMoveCommand
    {
        private readonly MouseMoverService _mouseMoverService;

        public StartCommand(MouseMoverService mouseMoverService)
        {
            _mouseMoverService = mouseMoverService;
        }

        public void Execute()
        {
            _mouseMoverService.Start();
        }
    }
}
