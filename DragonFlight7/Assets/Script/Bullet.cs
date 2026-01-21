using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1;
    public GameObject effect;
    void Start()
    {
        
    }

  
    void Update()
    {
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면밖으로 나가면 호출되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //trigger 충돌일경우 한번실행
        if (collision.gameObject.CompareTag("Enemy"))
        {

            //이펙트 생성
            GameObject go  = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            //싱글톤 함수 호출
            SoundManager.instance.SoundDie();

            //점수
            GameManager.Instance.AddScore(100);


            //적충돌
            //적삭제
            Destroy(collision.gameObject);

            //자기자신삭제
            Destroy(gameObject);
        }
    }



}
