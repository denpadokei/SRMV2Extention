using SongRequestManagerV2.Bases;
using SongRequestManagerV2.Statics;

namespace SRMV2Extention.Models
{
    /// <summary>
    /// 単体追加の例
    /// </summary>
    public class SRMExtentionCommand : SRMCommandBase
    {
        public override void Constractor()
        {
            Plugin.Log.Debug("Initialize!");
            this.Setup("!denpadokei").Action((c, s) => { this._bot.QueueChatMessage($"テストだよー！ from {c.DisplayName}"); }).Help(FlagParameter.Everyone, "ショートテストです。");
        }
    }
}
