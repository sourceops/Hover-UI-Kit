﻿using Hover.Board.State;
using Hover.Common.Custom;
using Hover.Common.State;
using UnityEngine;

namespace Hover.Board.Display.Standard {

	/*================================================================================================*/
	public class UiItemSliderGrabRenderer : UiItemBaseIconRenderer {

		private static readonly Texture2D IconTex = Resources.Load<Texture2D>("Slider");
		private static readonly Quaternion IconRot =
			Quaternion.FromToRotation(Vector3.up, Vector3.right);


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected override Texture2D GetIconTexture() {
			return IconTex;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected override Vector3 GetIconScale() {
			float sx = vSettings.TextSize/1.25f*LabelCanvasScale;
			float sy = vSettings.TextSize*LabelCanvasScale;
			return new Vector3(sx, sy, 1);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public override void Build(IHoverboardPanelState pPanelState,
										IHoverboardLayoutState pLayoutState, IBaseItemState pItemState,
										IItemVisualSettings pSettings) {
			base.Build(pPanelState, pLayoutState, pItemState, pSettings);
			vIcon.transform.localRotation *= IconRot;
		}

	}

}
