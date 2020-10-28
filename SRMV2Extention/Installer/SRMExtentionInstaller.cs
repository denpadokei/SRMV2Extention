using SongRequestManagerV2.Interfaces;
using SongRequestManagerV2.Statics;
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
            foreach (var item in this.CreateCommand()) {
                Container.Bind<ISRMCommand>().FromInstance(item);
            }
        }

        /// <summary>
        /// 複数の挙動を一気に追加する例（Botにアクセスはできません。）
        /// </summary>
        /// <returns></returns>
        IEnumerable<ISRMCommand> CreateCommand()
        {
            yield return new SRMExtentionCommand().Setup("!denpadokei1").Action((c, s) => { Plugin.Log.Debug("ここに自分の作ったメソッド１"); }).Help(FlagParameter.Everyone);
            yield return new SRMExtentionCommand().Setup("!denpadokei2").Action((c, s) => { Plugin.Log.Debug("ここに自分の作ったメソッド２"); }).Help(FlagParameter.Everyone);
            yield return new SRMExtentionCommand().Setup("!denpadokei3").Action((c, s) => { Plugin.Log.Debug("ここに自分の作ったメソッド３"); }).Help(FlagParameter.Everyone);
        }
    }
}
