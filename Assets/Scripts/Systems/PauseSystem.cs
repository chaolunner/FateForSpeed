﻿using UniRx.Triggers;
using UnityEngine;
using UniECS;
using System;
using UniRx;

public class PauseSystem : SystemBehaviour
{
	public override void Awake ()
	{
		base.Awake ();

		var PauseEntities = GroupFactory.Create (new Type[] {
			typeof(PauseComponent)	
		});

		PauseEntities.OnAdd ().Subscribe (entitiy => {
			var pauseComponent = entitiy.GetComponent<PauseComponent> ();

			pauseComponent.OnPointerClickAsObservable ().Subscribe (_ => {
				pauseComponent.IsPause.Value = !pauseComponent.IsPause.Value;
			}).AddTo (this.Disposer).AddTo (pauseComponent.Disposer);

			pauseComponent.IsPause.DistinctUntilChanged ().Subscribe (b => {
				if (b) {
					Time.timeScale = 0;
				} else {
					Time.timeScale = 1;
				}
			}).AddTo (this.Disposer).AddTo (pauseComponent.Disposer);

			EventSystem.OnEvent<LoadSceneStart> ().Subscribe (_ => {
				pauseComponent.IsPause.Value = false;
			}).AddTo (this.Disposer).AddTo (pauseComponent.Disposer);
		}).AddTo (this.Disposer);
	}
}