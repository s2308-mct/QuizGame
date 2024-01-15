using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class csvReader : MonoBehaviour
{
    TextAsset csvFile; // CSV�t�@�C��
    List<string[]> csvData = new List<string[]>(); // CSV�t�@�C���̒��g�����郊�X�g

    private int qnum; //���ԍ�
    public Text quest; //��蕶
    public Text[] choices = new Text[4]; //
    public static int ans; //����
    public static string answer;


    // Start is called before the first frame update
    void Start()
    {
        csvFile = Resources.Load("quiz") as TextAsset; // Resources�ɂ���CSV�t�@�C�����i�[
        StringReader reader = new StringReader(csvFile.text); // TextAsset��StringReader�ɕϊ�

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s���ǂݍ���
            csvData.Add(line.Split(',')); // csvData���X�g�ɒǉ�����
        }

        System.Random rand = new System.Random();
        qnum = rand.Next(0, csvData.Count);//�����_���ɖ�茈��

        quest.text = string.Format("{0}", csvData[qnum][0]); //��蕶
        for (int i = 0; i < 4; i++) //�I����
        {
            choices[i].text = string.Format(csvData[qnum][i + 1]);
        }
        ans = int.Parse(csvData[qnum][5]); //�����ԍ�
        answer = choices[ans - 1].text;
    }
}
