﻿using System.Collections;
using Cysharp.Threading.Tasks;
using GameFrameX.Asset.Runtime;
using GameFrameX.Fsm.Runtime;
using GameFrameX.Procedure.Runtime;
using UnityEngine;
using YooAsset;

namespace GameFrameX.Procedure
{
    internal sealed class ProcedureUpdateManifest : GSProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            PatchEventDispatcher.SendPatchStepsChangeMsg(EPatchStates.UpdateManifest);
            UpdateManifest(procedureOwner).ToUniTask();
        }


        private IEnumerator UpdateManifest(IFsm<IProcedureManager> procedureOwner)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            var package = YooAssets.GetPackage(AssetComponent.BuildInPackageName);
            var operation = package.UpdatePackageManifestAsync(GameApp.Asset.StaticVersion);
            yield return operation;

            if (operation.Status == EOperationStatus.Succeed)
            {
                //更新成功
                ChangeState<ProcedureCreateDownloader>(procedureOwner);
            }
            else
            {
                //更新失败
                Debug.LogError(operation.Error);
                PatchEventDispatcher.SendPatchManifestUpdateFailedMsg();
                ChangeState<ProcedureUpdateManifest>(procedureOwner);
            }
        }
    }
}