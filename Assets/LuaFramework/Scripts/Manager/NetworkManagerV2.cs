using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LuaFramework;


//���� ���� ���� (http socket��������)

//��Ϸ������ ����Ϣ

//ת�ջ� 
//    => �����쳣  ����û�лص�

//    => �����ӳ�
    
//    => �������쳣 û�л�Ӧ

//    => ���˶�����

//ͨͨ���ù� 
    
//    =>  ����һ������ ������û�л�Ӧ 
//    =>  �ȴ�һ��ʱ�� �������� 
//public enum NetType
//{
//    chat,
//    login
//}
public class NetworkManagerV2 : Manager
{




    //public SelfNetwork newWork;
    
    //public class NetChanelUnit
    //{

    //    //public NetType netType = NetType.login;
        

        
    //    //public Queue<KeyValuePair<int, object>> sEvents;



    //    public NetChanelUnit()
    //    {
    //        //this.ip = ip;
    //        //this.port = port;
    //        //this.netType = netType;
    //        //this.newWork = new SelfNetwork();
    //        //this.sEvents = new Queue<KeyValuePair<int, object>>();
    //    }

    //    public virtual void Update(){}

    //    public virtual void LinkServer()
    //    {
    //        //Debug.Log(" LinkServer ip " + ip + " port" + port + " netType " + netType.ToString());
    //        newWork.LinkServer(ip, port); 
    //    }

    //    //public virtual void SendMessage(BasePacket pkt)
    //    //{
    //    //    //Debug.Log("ip " + ip + " port" + port + " netType " + netType.ToString() + " ptkType " + pkt.pktType);

    //    //    this.newWork.SendPacket(pkt);
    //    //}



    //    public virtual void Release()
    //    {
    //        this.isConnect = false;
    //        this.newWork.CloseConnect();
    //    }

    //    // --�����ӽ���ʱ--
    //    public virtual void OnConnect()
    //    {
    //        this.isConnect = true;
    //        //Debug.Log(" OnConnect " + netType.ToString()); 
    //    }


    //    public void OnConnectError() {
    //        this.isConnect = false;
    //        //this.newWork.Destroy();
    //    }

    //    // -- �쳣���� --
    //    // -- �ȴ� ���� ���� --
    //    public void OnNetError()
    //    {
    //        this.isConnect = false;
    //        //this.newWork.Destroy();
    //        //Debug.Log(" OnNetError " + netType.ToString()); 
    //    }

    //     //���ܵ�������Ϣ
    //    public virtual void OnSocketMsg(object[] objs)
    //    {
    //        if (objs == null || objs.Length == 0) return;
    //        int ptkType = (int)objs[0];
    //        int error = (int)objs[1];
    //        Byte[] al = (Byte[])objs[2];
    //        if (error != 0)
    //        {
    //            //Debug.Log(" SocketMsgError " + netType.ToString() + " error " + error);
    //            //GameMain.Instance.evt.CallEvent(Opcodes.SocketMsgError, error);
    //        }
    //        else
    //        {
    //            //Debug.Log(" OnSocketMsg netType " + netType.ToString() + " ptkType " + ptkType);
    //            //GameMain.Instance.evt.CallEvent(ptkType, al);
    //        }
    //    }
    //}

    //public class LoginChanelUnit : NetChanelUnit
    //{
    //    //public LoginChanelUnit(NetType netType)
    //    //    : base(netType)
    //    //{

    //    //}

    //    public override void OnConnect()
    //    {
    //        base.OnConnect();


    //        Debug.Log("ready login gameserver");
    //        //LoginMsg cl = new LoginMsg();
    //        //cl.data.token = GameMain.Instance.dataPool.roleModel.token;
    //        //cl.data.platform = (int)AppConst.ptqd;
    //        //cl.data.version = "0.1.0";
    //        //GameMain.Instance.Send(cl);

    //        //GameMain.Instance.evt.AddListener(Opcodes.RESPONSE_LOGIN_MSG, onRESPONSE_LOGIN_MSG);
    //    }

    //    public float headTimer = 0f;
    //    public override void Update ()
    //    { 
    //        //������
    //        //if(this.isConnect && (this.headTimer -= RealTime.deltaTime) < 0f)
    //        //{
    //        //    this.headTimer = 60.0f;
    //        //    Debug.Log("tet");
    //        //    this.newWork.HeatUpdate();
    //        //}
    //    }

    //    public int preCode = -1;

    //    //public override void SendMessage(BasePacket pkt)
    //    //{
    //    //    NetworkManager.Instance.isWaiting = true;

    //    //    this.preCode = pkt.pktType;

    //    //    //Debug.Log("....................................... SendMessage pkt.pktType " + pkt.pktType);

    //    //    base.SendMessage(pkt);
    //    //}

    //    public override void OnSocketMsg(object[] objs) {

    //        if (objs == null || objs.Length == 0) return;
            
    //        int ptkType = (int)objs[0];
    //        int error = (int)objs[1];
    //        Byte[] al = (Byte[])objs[2];

    //        #region legacy
    //        ///��Ӧ���� == �������
    //        //if ((this.preCode + 2000) == ptkType) {
    //        //    NetworkManager.Instance.isWaiting = false;
    //        //} 

    //        //if (error != 0)
    //        //{
    //        //    //Debug.Log(" SocketMsgError " + netType.ToString() + " error " + error);
    //        //    GameMain.Instance.evt.CallEvent(Opcodes.SocketMsgError, error);
    //        //}
    //        //else
    //        //{
    //        //    //Debug.Log(" OnSocketMsg netType " + netType.ToString() + " ptkType " + ptkType);
    //        //    GameMain.Instance.evt.CallEvent(ptkType, al);
    //        //}
    //        #endregion
            
    //    }
    //}


    //private bool _isWaiting = false; ///�Ƿ����ڵȴ�������Ϣ��Ӧ
    //public bool isWaiting { 
    //    get { 
    //        return _isWaiting; 
    //    } 
    //    set { 
    //        _isWaiting = value;
    //        Debug.Log(" _isWaiting " + value);
    //        //Messenger.Broadcast<bool>(NotiConst.RequestNetResponse.ToString(), _isWaiting);
    //    }
    //}

    //int netTypeLength;
    //public LoginChanelUnit login_channel_unit;
    //public LoginChanelUnit login_channel_unit
    //{
    //    get
    //    {
    //        return NetworkManager.Instance.channelUnit[(int)NetType.login] as LoginChanelUnit;
    //    }
    //}
    //public ChatUnit chat_channel_unit { 
    //    get {
    //        return NetworkManager.Instance.channelUnit[(int)NetType.chat] as ChatUnit;
    //    } 
    //}


    public string ip;
    public int port;

    public SelfNetwork newWork;

    void Awake()
    {
        this.newWork = new SelfNetwork();
        this.newWork.OnRegister();
    }

    public void OnInit()
    {
        //CallMethod("Start");
        Util.CallMethod("Network", "Start");
    }

    //void OnEnable()
    //{
        

        //GameMain.Instance.evt.AddListener(NotiConst.Connect, OnConnect);
        //GameMain.Instance.evt.AddListener(NotiConst.ConnectError, OnConnectError);

        //GameMain.Instance.evt.AddListener(NotiConst.NetError, OnNetError);

        //GameMain.Instance.evt.AddListener(NotiConst.SocketPack, OnSocketMsg);
        //GameMain.Instance.evt.AddListener(Opcodes.SocketMsgError, OnSocketError);
    //}

    public void Update()
    {
        //for (int i = 0; i < netTypeLength; i++)
        //{
        //    channelUnit[i].DispatchEvent();
            //if (channelUnit[i].sEvents.Count > 0)
            //{
            //    while (channelUnit[i].sEvents.Count > 0)
            //    {
            //        KeyValuePair<int, object> _event = channelUnit[i].sEvents.Dequeue();
            //        GameMain.Instance.evt.CallEvent(_event.Key, _event.Value);
            //    }
            //}
        //}

        DispatchEvent();
        
        HeatBeat();

        ////for (int i = 0; i < netTypeLength; i++)
        ////{
        ////    channelUnit[i].Update();
        ////}
        //Update();
    }

    //void OnDisable()
    //{
    //    Util.CallMethod("Network", "OnDisable");

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.Connect, OnConnect);
    //    //GameMain.Instance.evt.RemoveListener(NotiConst.ConnectError, OnConnectError);

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.NetError, OnNetError);

    //    //GameMain.Instance.evt.RemoveListener(NotiConst.SocketPack, OnSocketMsg);
    //    //GameMain.Instance.evt.RemoveListener(Opcodes.SocketMsgError, OnSocketError);
    //}
    public void Unload()
    {
        Util.CallMethod("Network", "Unload");
    }

    /// <summary>
    /// ��������
    /// </summary>
    void OnDestroy()
    {
        this.newWork.OnRemove();
        Debug.Log("~NetworkManager was destroy");
    }

    public void SendConnect()
    {
        this.newWork.LinkServer(AppConst.SocketAddress, AppConst.SocketPort);
    }

    public void SendMessage(ByteBuffer buffer)
    {
        //Debug.Log("SendMessage");
        this.newWork.SendMessage(buffer);
    }

    //public void Release() {
        
    //    //for (int i = 0; i < netTypeLength; i++)
    //    //{
    //    //    //channelUnit[i].newWork.Destroy();
    //    //    channelUnit[i].Release();
    //    //}
        
    //    this.login_channel_unit.Release();


    //    Debug.Log("~ net Release");
    //}


    //public void LinkServer(string ip, int port)
    //{
    //    this.newWork.LinkServer(ip, port);
    //}



    // -- ����SOCKET��Ϣ --
    //public void SendMessage(NetType netType, BasePacket pkt)
    //{
    //    //channelUnit[(int)netType].SendMessage(pkt);

    //    //if (netType == NetType.login)
    //    //{
    //    //    NetworkManagerV2.Instance.isWaiting = true;

    //    //    //channelUnit[(int)netType].preCode = pkt.pktType;

    //    //    this.login_channel_unit.preCode = pkt.pktType;
    //    //    //Debug.Log("....................................... SendMessage pkt.pktType " + pkt.pktType);

    //    //    //base.SendMessage(pkt);
    //    //    this.login_channel_unit.newWork.SendPacket(pkt);
    //    //}
    //    //else
    //    //{
    //    //    this.login_channel_unit.newWork.SendPacket(pkt);
    //    //}
    //}



    // --���ӳɹ�--
    //public void OnConnect(object arg)
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnConnect();

    //    //Debug.Log(" OnConnect " + netType.ToString()); 
    //}

    // --����ʧ��--
    //public void OnConnectError(object arg) 
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnConnectError();

    //    //SceneMgr.Instance.CreateTip("�����쳣!");
    //}

    // -- ������׳�--
    // -- �п��������û�м�⵽ ��ô�ϲ�UI�ջ�̫����Ҳ���׳� --
    //public void OnNetError(object arg)
    //{
    //    NetworkManagerV2.Instance.isWaiting = false;

    //    NetType netType = (NetType)arg;

    //    this.login_channel_unit.OnNetError();

    //    //Debug.Log(" OnNetError " + netType.ToString()); 

    //    //SceneMgr.Instance.CreateTip("�����쳣 ɧ��������!ôô��!");
    //}

    //public void OnSocketMsg(object arg)
    //{
    //    object[] objs = (object[])arg;

    //    NetType netType = (NetType)objs[0];
    //    //Debug.Log("SocketMsg" + netType.ToString());
    //    this.login_channel_unit.OnSocketMsg((object[])objs[1]);
    //}

    //private void OnSocketError(object arg)
    //{
    //    ///��Щ�����������Ҫ��Ĵ���
    //    int error = (int)arg;
    
    //    //CfgErrcodeVo errorVo = StaticDataPool.Instance.configErrorCodePool.GetErrorVo(error);
    //    //Debugger.Log(errorVo != null ? errorVo.msg : " ������� " + error);
    //    //SceneMgr.Instance.CreateTip(errorVo!= null ? errorVo.msg : "�������" + error);
    //}

    //public T Parse<T>(object obj)
    //{
        //Byte[] arg = (Byte[])obj;
        //using (System.IO.Stream getStream = new System.IO.MemoryStream(arg)) 
        //{
        //    T res = ProtoBuf.Serializer.Deserialize<T>(getStream);
        //    return res;
        //}
    //}

    static readonly object m_lockObject = new object();
    static Queue<KeyValuePair<int, ByteBuffer>> mEvents = new Queue<KeyValuePair<int, ByteBuffer>>();
    public static void AddEvent(int _event, ByteBuffer data)
    {
        lock (m_lockObject)
        {
            mEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
        }
    }

    void DispatchEvent()
    {
        lock (m_lockObject)
        {
            if (mEvents.Count > 0)
            {
                //Debug.Log(" mEvents.Count " + mEvents.Count);
                while (mEvents.Count > 0)
                {
                    KeyValuePair<int, ByteBuffer> _event = mEvents.Dequeue();
                    facade.SendMessageCommand(NotiConst.DISPATCH_MESSAGE, _event);
                }
            }
        }
    }



    //public bool isConnect = false; ///��ǰchanel�Ƿ�������
    ///
    public float headTimer = 0f;
    void HeatBeat()
    {
        //������
        //if(this.isConnect && (this.headTimer -= RealTime.deltaTime) < 0f)
        //{
        //    this.headTimer = 60.0f;
        //    Debug.Log("tet");
        //    this.newWork.HeatUpdate();
        //}
    }
}
