using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    public static GameManager Instance;
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아오기

    int score = 0; //점수를 관리


    private void Awake()
    {
        if(Instance == null) //정적으로 자신을 체크
        {
            Instance = this; //자기자신을 인스턴스해서 저장
        }
    }


    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : "+score; //텍스트에 반영
    }






    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
