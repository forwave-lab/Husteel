using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeMake.Class;
using DevExpress.XtraReports.UI;
using QRCodeMake.BCR;

namespace QRCodeMake
{
    public partial class BCR_Print : Form
    {
        Dictionary<string, string> Parm = new Dictionary<string, string>();
        Common_BCR_Print common_BCR_Print = new Common_BCR_Print();

        public BCR_Print()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string DocNo = string.Empty;
            string result = string.Empty;   //결과메세지
            int copies = 1;                 //출력매수

            DocNo = comboBox1.SelectedValue.ToString();

            Parm = this.GetParm(copies,DocNo);
            if(Parm["Bcr_Result"] == "OK")
            {
                result = common_BCR_Print.initPrint(Parm);
            }
            else
            {
                result = Parm["Bcr_Result"];
            }
            
            //MessageBox.Show(result);
        }

        private Dictionary<string,string> GetParm(int copies, string DocNo)
        {
            var result = new Dictionary<string, string>();
            try
            {                
                result.Add("Bcr_DocType", DocNo);                           //바코드문서(공정ID - 스켈프:100, 절단:104, 관단:105, 흑관하조:303, 백관하조:365,수출:900)
                result.Add("Bcr_Id", "SAME AS OPPOSITE");                   //ID(바코드생성용)
                result.Add("Bcr_PoNo", "CB80164");                          //PO NO
                result.Add("Bcr_SoNo", "05004");                      //수주번호
                result.Add("Bcr_Wo", "PD22110127");                         //제조오더
                result.Add("Bcr_ProductName", "S0-POSP340A / 148 / 2.9");   //품종
                result.Add("Bcr_Spec", "POSP340A * 148 * 2.9");             //치수
                result.Add("Bcr_Qty", "14911");                             //본수
                result.Add("Bcr_LotNo", "2K27D0001");               //Lot No
                result.Add("Bcr_Coating", "코팅유 511");                    //코팅
                result.Add("Bcr_Inspector", "권영탁");            //책임검사자    
                result.Add("Bcr_BP", "VANCOUVER-BC");                       //주문처
                result.Add("Bcr_HeatNo", "A38093");                 //Heat No
                result.Add("Bcr_Kind", "ABCD");                             //재질
                result.Add("Bcr_CoilNo", "PD22110127");                     //Coil No
                result.Add("Bcr_Weight", "7000");                           //중량
                result.Add("Bcr_Diameter", "610.0");                        //외경
                result.Add("Bcr_Thickness", "0990");                        //두께
                result.Add("Bcr_Length", "6.000");                          //길이
                result.Add("Bcr_Marking", "Marking");                       //마킹정보
                result.Add("Bcr_Date", "11/28");                            //생산일자
                result.Add("Bcr_PCSLIFT", "3 PCS/LIFT");                    //PCS/LIFT
                result.Add("Bcr_BundleNo", "");                             //번들 No
                result.Add("Bcr_Note", "시편");                             //비고
                result.Add("Bcr_Desc", "특이사항이표시됩니다.");             //특이사항
                result.Add("Bcr_Cnt", copies.ToString());                   //출력매수
                result.Add("Bcr_TagLotNo", "2K27D");                        //Tag LotNo
                result.Add("Bcr_Result", "OK");                             //Message
                return result;
            }
            catch (Exception ex)
            {
                result.Add("Bcr_Result", ex.Message.ToString());          //Message
                return result;
            }
        }

        private void BCR_Print_Load(object sender, EventArgs e)
        {
            string[] data = { "100", "104", "105", "303", "900" };
            BindingList<object> typeList = new BindingList<object>();

            // 각 콤보박스에 데이타를 초기화
            typeList.Add(new { Text = "Slitting", Value = "100" });
            typeList.Add(new { Text = "Cutting", Value = "104" });
            typeList.Add(new { Text = "Bevel", Value = "105" });
            typeList.Add(new { Text = "Package", Value = "303" });
            typeList.Add(new { Text = "Export", Value = "900" });

            // 처음 선택값 지정. 첫째 아이템 선택
            comboBox1.DataSource = typeList;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

        }
    }
}
