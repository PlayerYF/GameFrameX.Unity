using GameFrameX.Fsm.Runtime;
using GameFrameX.Procedure.Runtime;
using GameFrameX.Runtime;

namespace GameFrameX.Procedure
{
    public abstract class GSProcedureBase : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Log.Info(" | -> Procedure : {0} | ", GetType().Name);
        }
    }
}