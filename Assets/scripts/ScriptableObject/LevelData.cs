using Newtonsoft.Json.Linq;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/LevelData")]
public class LevelData : Data
{
    public string levelName;
    public int colectedCoins;
    public int maxCoins;
    public float bestTime;
    public bool isComplete;


    public override void DeSerialize(string jsonString)
    {
        SaveData sd = JsonUtility.FromJson<SaveData>(jsonString);

        colectedCoins = sd.colectedCoins;
        maxCoins = sd.maxCoins;
        bestTime = sd.bestTime;
        isComplete = sd.isComplete;
    }

    public override JObject Serialize()
    {
       SaveData sd = new SaveData(colectedCoins, maxCoins, bestTime, isComplete);
        string jsonString = JsonUtility.ToJson(sd);
        JObject retVal = JObject.Parse(jsonString);
        return retVal;
    }

    private class SaveData
    {
        public int colectedCoins;
        public int maxCoins;
        public float bestTime;
        public bool isComplete;

        public SaveData(int colectedCoins, int maxCoins, float bestTime, bool isComplete)
        {
            this.colectedCoins = colectedCoins;
            this.maxCoins = maxCoins;
            this.bestTime = bestTime;
            this.isComplete = isComplete;
        }
    }
}
