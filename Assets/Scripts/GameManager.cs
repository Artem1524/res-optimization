using UnityEngine;
using UnityEngine.UI;

namespace Runner
{
    public class GameManager : MonoBehaviour
    {
        private int _progress = 0;

        private float _step = 6f;
        private int _currentIndex = 0;
        private float _lastZ = 30f;
<<<<<<< HEAD
=======
        private int _levelsLength = 1024 * 1024;
>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420

        [SerializeField, Range(1, 100), Tooltip("Это здоровье игрока, не перепутай")]
        private int Health = 3;
        [SerializeField]
        private Transform _player;
        [SerializeField]
        private Transform[] _levels;
        [SerializeField, Space]
        private Text _text;


        public static GameManager Self { get; private set; }

<<<<<<< HEAD
=======


>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420
        void Awake()
        {
            Self = this;
        }

		private void Update()
		{
            Debug.Log("Game Manager Update");
            if (_player.position.y <= -1f) SetDamage();
        }

		public void SetDamage()
        {
            Health -= 1;

            Debug.Log("Current health: " + Health);

            if(Health <= 0)
            {
                Debug.Log("---Игрок погиб!---");
                UnityEditor.EditorApplication.isPaused = true;
			}
		}

        public void UpdateLevel()
        {
<<<<<<< HEAD
            _lastZ += _step;
            
            MoveCurrentBlockToLast(_currentIndex);
            IncreaseCurrentBlockIndex();
            
            _progress++;
            UpdateUI(_progress);
	    }
	    
	    private void MoveCurrentBlockToLast(int currentBlockIndex)
	    {
	        var position = _levels[currentBlockIndex].position;
                position.z = _lastZ;
                _levels[currentBlockIndex].position = position;
	    }
	    
	    private void IncreaseCurrentBlockIndex()
	    {
	        _currentIndex++;
            
                if (_currentIndex >= _levels.Length)
                    _currentIndex = 0;
	    }
	    
	    private void UpdateUI(int completedLevelsCount)
	    {
	        _text.text = completedLevelsCount.ToString();
	    }
    }
}
=======
            _progress++;
            _text.text = _progress.ToString();

            _lastZ += _step;
            for(int i = 0; i < _levelsLength; i++)
            {
                var position = _levels[_currentIndex].position;
                position.z = _lastZ;
                _levels[_currentIndex].position = position;
            }

            _currentIndex++;
            if (_currentIndex >= _levels.Length)
            {
                _currentIndex = 0;
            }
	    }
    }
}
>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420
