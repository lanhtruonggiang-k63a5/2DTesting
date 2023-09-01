using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Giang
{
    public class GameManager : MonoBehaviour
    {
        public TextAsset jsonFile;
        public Player player1;
        private void Start()
        {
            player1.playerInfo = JsonUtility.FromJson<PlayerInfo>(jsonFile.text);

            var instanceObj = Instantiate(player1 );

            Debug.Log(this.name + @$" player : {instanceObj.name}
             {instanceObj.playerInfo.health} {instanceObj.playerInfo.lives} ", gameObject);


        }
    }
}

