﻿using UnityEngine.UI;
using UnityEngine;

[RequireComponent (typeof(ScrollRect))]
[RequireComponent (typeof(RectTransform))]
public class CenterAlignment : MonoBehaviour
{
	[Range (0, 3)]
	public float scale = 1.5f;
	public RectTransform center;
	private ScrollRect scrollView;
	private BoxCollider2D centerCollider;
	private GridLayoutGroup gridLayoutGroup;

	void Start ()
	{
		if (center == null) {
			center = transform as RectTransform;
		}
		scrollView = GetComponent<ScrollRect> ();
		gridLayoutGroup = scrollView.content.GetComponent<GridLayoutGroup> ();

		centerCollider = gameObject.AddComponent<BoxCollider2D> ();
		centerCollider.size = gridLayoutGroup.cellSize;
		centerCollider.isTrigger = true;

		for (int i = 0; i < scrollView.content.childCount; i++) {
			var child = scrollView.content.GetChild (i) as RectTransform;
			var col = child.gameObject.AddComponent<BoxCollider2D> ();
			var rig = child.gameObject.AddComponent<Rigidbody2D> ();
			rig.sleepMode = RigidbodySleepMode2D.NeverSleep;
			col.size = gridLayoutGroup.cellSize;
			col.isTrigger = true;
			rig.gravityScale = 0;
		}
	}

	void OnTriggerStay2D (Collider2D col)
	{
		if (col.gameObject.layer == LayerMask.NameToLayer ("UI")) {
			var k = 1f;
			var distance = Vector3.Distance (col.transform.position, center.position);
			if (scrollView.horizontal) {
				k -= Mathf.Clamp01 (distance / centerCollider.bounds.size.x);
			} else {
				k -= Mathf.Clamp01 (distance / centerCollider.bounds.size.y);
			}
			col.transform.localScale = (1 + k * (scale - 1)) * Vector3.one;
		}
	}

	void OnTriggerExit2D (Collider2D col)
	{
		if (col.gameObject.layer == LayerMask.NameToLayer ("UI")) {
			col.transform.localScale = Vector3.one;
		}
	}
}
