using SongRequestManagerV2.Interfaces;
using SRMV2Extention.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace SRMV2Extention.Installer
{
    public class SRMExtentionInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<SRMExtentionCommand>().AsTransient();
        }
    }
}
