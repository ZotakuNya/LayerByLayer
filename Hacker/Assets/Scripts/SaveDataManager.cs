using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

public class SaveDataManager : MonoBehaviour
{
    public GameObject blankStat;
    public GameObject createStat;
    public GameObject dataSata;

    public GameObject desktop;

    public Text unameOnCreate;
    public Text pwdOnCreate;
    public Text unameOnData;
    public InputField pwdOnData;

    private string _path;
    private SaveData _curData;

    public ErrorHandle eh;

    private void Start()
    {
        _path = Application.dataPath + "/StreamingFile" + "/" + gameObject.name + ".txt";
        if (File.Exists(_path))
        {
            _curData = LoadByBin();
            
            createStat.SetActive(false);
            dataSata.SetActive(true);
            blankStat.SetActive(false);

            unameOnData.text = _curData.Username;
        }
        else
        {
            createStat.SetActive(false);
            dataSata.SetActive(false);
            blankStat.SetActive(true);
        }
    }

    public void BackToBlankStat()
    {
        createStat.SetActive(false);
        dataSata.SetActive(false);
        blankStat.SetActive(true);
    }

    public void CreateSavaData()
    {
        blankStat.SetActive(false);
        createStat.SetActive(true);
        dataSata.SetActive(false);
    }

    public void SetUpSaveData()
    {
        string uname = unameOnCreate.text;
        string pwd = pwdOnCreate.text;

        if (uname == "" && pwd == "")
        {
            Debug.Log("Empty");
        }
        else
        {
            blankStat.SetActive(false);
            createStat.SetActive(false);

            _curData = new SaveData();
            _curData.Username = uname;
            _curData.Passwd = pwd;
            SaveByBin(_curData);
            
            dataSata.SetActive(true);
            unameOnData.text = _curData.Username;
        }
    }

    public void DeleteSaveData()
    {
        createStat.SetActive(false);
        dataSata.SetActive(false);
        blankStat.SetActive(true);
        
        File.Delete(_path);
    }

    public void EnterMain()
    {
        string pwd = pwdOnData.text;
        if (pwd == _curData.Passwd)
        {
            desktop.SetActive(true);
            transform.parent.gameObject.SetActive(false);
        }
        else if (pwd == "")
        {
            eh.ErrorReport("请输入密码");
        }
        else
        {
            eh.ErrorReport("密码错误");
        }
    }
    
    private void SaveByBin(SaveData save)
    {
        //创建一个二进制格式化程序
        BinaryFormatter bf = new BinaryFormatter();
        //创建一个文件流
        FileStream fileStream = File.Create(_path);

        //用二进制格式化程序的序列化方法来序列化Save对象，参数：创建的文件流和需要序列化的对象
        bf.Serialize(fileStream, save);
        //关闭流
        fileStream.Close();
    }
    
    private SaveData LoadByBin()
    {
        //反序列化过程
        //创建一个二进制格式化程序
        BinaryFormatter bf = new BinaryFormatter();
        //打开一个文件流
        FileStream fileStream = File.Open(_path,FileMode.Open);
        //调用格式化程序的反序列化方法，将文件流转换为一个save对象
        SaveData save = bf.Deserialize(fileStream) as SaveData;
        //关闭文件流
        fileStream.Close();
        return save;
    }
}
