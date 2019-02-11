using System;


namespace Solid
{
    interface IPhone
    {
        void MakeCall(string number);
        void FindContact(string name);
        void AddNewContact(string number, string name);
        void CreateMessage(string text);
        void SendMessage(string number, string text);
        void SetTime(DateTime time);
        void SetAlarmTime(DateTime time);
        void OnCamera();
        void OffCamera();
        void DoAFoto();
        void SaveFoto(string fotoName);

    }
    interface ICallPhone
    {
        void MakeCall(string number);
        void FindContact(string name);
        void AddNewContact(string number, string name);
        void CreateMessage(string text);
        void SendMessage(string number, string text);
    }
    interface IAlarm
    {
        void SetTime(DateTime time);
        void SetAlarmTime(DateTime time);
    }
    interface ICamera
    {
        void OnCamera();
        void OffCamera();
        void DoAFoto();
        void SaveFoto(string fotoName);
    }
}
