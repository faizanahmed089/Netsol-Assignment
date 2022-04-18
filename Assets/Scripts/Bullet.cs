//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Bullet : MonoBehaviour
//{
//	float moveSpeed = 7f;
//	private Rigidbody rb;

//	Enemy target;
//	Vector3 moveDirection;

//	void Start()
//	{
//		rb = GetComponent<Rigidbody>();
//		target = GameObject.FindObjectOfType<Enemy>();
//		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
//		rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
//		Destroy(gameObject, 3f);
//	}

//	void OnCollisionEnter(Collision col)
//	{
//		if (col.gameObject.name.Equals("Enemy"))
//		{
//			Debug.Log("Hit!");
//			Destroy(gameObject);
//		}
//	}
//}
