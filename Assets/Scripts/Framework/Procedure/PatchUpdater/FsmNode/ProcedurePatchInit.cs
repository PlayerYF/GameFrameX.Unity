﻿using Cysharp.Threading.Tasks;
using GameFrameX.Asset.Runtime;
using GameFrameX.Fsm;
using GameFrameX.Fsm.Runtime;
using GameFrameX.Procedure;
using GameFrameX.Procedure.Runtime;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.Procedure
{
    internal sealed class ProcedurePatchInit : GSProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            // Game.EventSystem.Run(EventIdType.UILoadingMainSetText, "Loading...");
            // 加载更新面板
            Start(procedureOwner);
        }

        async void Start(IFsm<IProcedureManager> procedureOwner)
        {
            GameApp.Asset.Initialize(GetHostServerURL(), GetHostServerURL());
            // 运行补丁流程
            PatchUpdater.Run();
            await UniTask.DelayFrame(10);

            ChangeState<ProcedureUpdateStaticVersion>(procedureOwner);
        }

        private string GetHostServerURL()
        {
            return $"{GameApp.GlobalConfig.HostServerUrl}";
        }
    }
}