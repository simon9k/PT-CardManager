using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Bouwa.Helper
{
    public class CurrentUser
    {
        //��̬ģʽ
        private static CurrentUser _currentUser;
        static CurrentUser()
        {
            CurrentUser._currentUser = new CurrentUser();
        }
        
        public static CurrentUser Current
        {
            get
            {
                return CurrentUser._currentUser;
            }
        }

        private CurrentUser()
        {
            
        }
        private Guid _UserId;      //�û�ID
        private string _UserCode; //��¼��
        private string _UserName;   //�û���
        private string _PassWord;    //����
        private bool _isLogin;     //�жϵ�¼�ɹ�
        private Form _LoginForm;//�����¼�������
        private string _PassWordKey = string.Empty; //���еĿ��������Ŵ�
        private Guid _NetWorkID = Guid.Empty; //����ID
        private object _RightInfoList = new object();
        public object RightInfoList
        { get { return _RightInfoList; } set { _RightInfoList = value; } }

        //private IList<object> _RightInfoList = new List<object>();
        //public IList<object> RightInfoList
        //{ get { return _RightInfoList; } set { _RightInfoList = value; } }

        private int _PageSize = 20;
        private int _PageIndex = 1;
        private int _PageCount = 0;
        private int _TotalCount = 0;

        private int _PARKING_SYSTEM = 0;//ͣ��ϵͳ
        /// <summary>
        /// 
        /// </summary>
        public int PARKING_SYSTEM
        {
            get { return _PARKING_SYSTEM; }
            set { _PARKING_SYSTEM = value; }
        }

        private int _PARK_BACKSTAGE = 2;//�շѺ�̨

        private int _CS_CLIENT = 4; //cs�ͻ���
        /// <summary>
        /// �շѺ�̨
        /// </summary>
        public int PARK_BACKSTAGE
        {
            get { return _PARK_BACKSTAGE; }
            set { _PARK_BACKSTAGE = value; }
        }

        /// <summary>
        /// cs�ͻ���
        /// </summary>
        public int CS_CLIENT
        {
            get { return _CS_CLIENT; }
            set { _CS_CLIENT = value; }
        }

        /// <summary>
        /// ע������
        /// </summary>
        private string _RegisterType = "background.register.type";
        /// <summary>
        /// ע������
        /// </summary>
        public string RegisterType
        {
            get { return _RegisterType; }
            set { _RegisterType = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        private string _maxMoney = "background.maxMoney";
        /// <summary>
        /// ���ʱ��
        /// </summary>
        private string _maxTime = "background.maxTime";
        /// <summary>
        /// ������
        /// </summary>
        private string _maxDegree = "background.maxDegree";
        /// CS �˿�����
        private string _cardPassword ="CS.cardPassword";

        /// <summary>
        /// �����
        /// </summary>
        public string CardPassword
        {
            get { return _cardPassword; }
            set { _cardPassword = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string MaxMoney
        {
            get { return _maxMoney; }
            set { _maxMoney = value; }
        }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public string MaxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string MaxDegree
        {
            get { return _maxDegree; }
            set { _maxDegree = value; }
        }

        /// <summary>
        /// ��ʾҳ��
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;

            }
            set
            {
                _PageSize = value;
            }
        }
        /// <summary>
        /// ��ǰҳ
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
            }
        }
        /// <summary>
        /// ��ҳ��
        /// </summary>
        public int PageCount
        {
            get
            {
                return _PageCount;
            }
            set
            {
                _PageCount = value;
            }
        }
        /// <summary>
        /// �ܼ�¼��
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _TotalCount;
            }
            set
            {
                _TotalCount = value;
            }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public Guid NetWorkID
        {
            get { return _NetWorkID; }
            set { _NetWorkID = value; }
        }
        private Guid _SAASID = Guid.Empty; //SAASID
        /// <summary>
        /// SAASID
        /// </summary>
        public Guid SAASID
        {
            get { return _SAASID; }
            set { _SAASID = value; }
        }


        /// <summary>
        /// ���п���������Դ
        /// </summary>
        public string PassWordKey
        {
            get { return _PassWordKey; }
            set { _PassWordKey = value; }
        }

        /// <summary>
        /// �����¼�������
        /// </summary>
        public Form LoginForm
        {
            get { return _LoginForm; }
            set { _LoginForm = value; }
        }
        /// <summary>
        /// ��ȡ������ �û�ID
        /// </summary>
        public Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }

        /// <summary>
        /// ��ȡ������ �û���¼��
        /// </summary>
        public string UserCode
        {
            get
            {
                return _UserCode;
            }
            set
            {
                _UserCode = value;
            }
        }
        /// <summary>
        /// ��ȡ������ �û���
        /// </summary>
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }

        /// <summary>
        /// �жϵ�¼�ɹ�
        /// </summary>
        public bool isLogin
        {
            get { return _isLogin; }
            set { _isLogin = value; }
        }

        private DateTime _EffectDateBegin = DateTime.MinValue;
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime EffectDateBegin
        {
            get { return _EffectDateBegin; }
            set { _EffectDateBegin = value; }
        }

        private DateTime _EffectDateEnd = DateTime.MaxValue;
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime EffectDateEnd
        {
            get { return _EffectDateEnd; }
            set { _EffectDateEnd = value; }
        }
    }
}
