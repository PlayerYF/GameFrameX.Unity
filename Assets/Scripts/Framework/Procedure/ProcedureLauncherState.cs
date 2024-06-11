using Cysharp.Threading.Tasks;
using GameFrameX.Fsm;
using GameFrameX.Fsm.Runtime;
using GameFrameX.Procedure;
using GameFrameX.Procedure.Runtime;

namespace GameFrameX.Procedure
{
    /// <summary>
    /// 启动游戏
    /// </summary>
    public class ProcedureLauncherState : GSProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            LauncherUIHandler.Start();
            Start(procedureOwner);
        }

        private async void Start(IFsm<IProcedureManager> procedureOwner)
        {
            await UniTask.NextFrame();
            ChangeState<ProcedureGetGlobalInfoState>(procedureOwner);
        }
    }
}