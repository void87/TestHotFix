using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestHotFix {

    public class GameManager {

        //private static GameManager instance;

        //public static GameManager Instance {
        //    get {
        //        if (instance == null) {
        //            instance = new GameManager();
        //        }
        //        return instance;
        //    }
        //}

        public void Init() {
            Debug.Log("GameManager Init");

            ABManager.Instance.Init();
            ABManager.Instance.DownloadVersionFile(() => {
                UIManager.Instance.InitLoading();
            });
        }

        public void Update() {

        }

        public void Destroy() {

        }
    }
}
