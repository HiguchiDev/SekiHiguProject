using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InstantiateTest : MonoBehaviour {

    //生成するゲームオブジェクト
    public GameObject target;

    int positionX =0;

    //Y軸の初期値、一つ前に生成されたY軸の位置を保存
    int positionYY =0;

    void Update(){
        //スペースを押したら
        if (Input.GetKeyDown (KeyCode.Space)) {

        	for(int i = 0;i < 100;i++){
        		//ランダム関数を使用してY軸の値を取得
        		int positionY = Random.Range( (positionYY - 5), (positionYY + 5) );
        		//Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            	Instantiate (target, new Vector3 (1.0f+(positionX), (positionYY)+(positionY), 0.0f), Quaternion.identity);

            	Instantiate (target, new Vector3 (1.0f+(positionX), (positionYY - 55)+(positionY + Random.Range( -3,3 )), 0.0f), Quaternion.identity);

            	positionYY = positionY;

            	positionX += 4;
        	}
            
        }
    }
}
