
//namespace LuaFramework {
    //public class Protocal {
    //    ///BUILD TABLE
    //    public const int Connect = 101;     //���ӷ�����
    //    public const int Exception = 102;     //�쳣����
    //    public const int Disconnect = 103;     //��������   
    //}


    public class Protocal 
    {
         public const int Connect		= 101;	//--���ӷ�����
         public const int ConnectError = 102; //-- ����ʧ��
         public const int Exception   = 103;	//--�쳣����
         public const int Disconnect  = 104;	//--��������
         public const int ReceiveTimeOut = 105; //-- ��Ϣ��ʱ���� 
         public const int Message		= 106;	//--������Ϣ
    }
//}