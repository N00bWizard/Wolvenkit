using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyGrabAttack : IBehTreeTask
	{
		[RED("attackType")] 		public CEnum<EAttackType> AttackType { get; set;}

		[RED("stopTaskAfterDealingDmg")] 		public CBool StopTaskAfterDealingDmg { get; set;}

		[RED("useDirectionalAttacks")] 		public CBool UseDirectionalAttacks { get; set;}

		[RED("fxOnDamageInstigated")] 		public CName FxOnDamageInstigated { get; set;}

		[RED("slave")] 		public CHandle<CActor> Slave { get; set;}

		[RED("slaveComponent")] 		public CHandle<CEffectDummyComponent> SlaveComponent { get; set;}

		public CBTTaskLeshyGrabAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskLeshyGrabAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}