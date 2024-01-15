using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class csvReader : MonoBehaviour
{
    TextAsset csvFile; // CSVファイル
    List<string[]> csvData = new List<string[]>(); // CSVファイルの中身を入れるリスト

    private int qnum; //問題番号
    public Text quest; //問題文
    public Text[] choices = new Text[4]; //
    public static int ans; //答え
    public static string answer;


    // Start is called before the first frame update
    void Start()
    {
        csvFile = Resources.Load("quiz") as TextAsset; // ResourcesにあるCSVファイルを格納
        StringReader reader = new StringReader(csvFile.text); // TextAssetをStringReaderに変換

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行ずつ読み込む
            csvData.Add(line.Split(',')); // csvDataリストに追加する
        }

        System.Random rand = new System.Random();
        qnum = rand.Next(0, csvData.Count);//ランダムに問題決定

        quest.text = string.Format("{0}", csvData[qnum][0]); //問題文
        for (int i = 0; i < 4; i++) //選択肢
        {
            choices[i].text = string.Format(csvData[qnum][i + 1]);
        }
        ans = int.Parse(csvData[qnum][5]); //答え番号
        answer = choices[ans - 1].text;
    }
}
