using ChatCore.Interfaces;
using SongRequestManagerV2.Bases;
using SongRequestManagerV2.Interfaces;
using SongRequestManagerV2.Models;
using SongRequestManagerV2.Statics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zenject;

namespace SRMV2Extention.Models
{
    public class SRMExtentionCommand : SRMCommandBase
    {

        public override void Constractor()
        {
            Plugin.Log.Debug("Initialize!");
            this.Setup("!denpadokei").Action((c, s) => { this._bot.QueueChatMessage($"テストだよー！ from {c.DisplayName}"); }).Help(FlagParameter.Everyone, "ショートテストです。");
        }
    }
}
