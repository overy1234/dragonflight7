using UnityEngine;

public class Enemy : MonoBehaviour
{
    //속도
    public float moveSpeed = 1.3f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;
        //움직이기
        transform.Translate(0, -distanceY, 0);



    }


    //컨트롤 + 쉬프트 + m
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //trigger 충돌일경우 한번실행
    //    if(collision.gameObject.CompareTag("Bullet"))
    //    {
    //        //미사일충돌
    //        //미사일삭제
    //        Destroy(collision.gameObject);

    //        //자기자신삭제
    //        Destroy(gameObject);
    //    }        
    //}
}
