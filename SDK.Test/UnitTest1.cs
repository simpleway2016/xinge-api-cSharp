using System;
using Xunit;
using System.Collections.Generic;
using XingeApp;
namespace SDK.Test
{
    public class UnitTest1
    {

        [Fact]
        public void JackTestToken()
        {
            string result = null;
            int messageIndex = Convert.ToInt32((DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds);

            var appID = "4c1723a2b00a8";
            var accessID = 2100316995;
            var secretKey = "ed911cc8d3e9d1472c41968fea86c99c";
            var token = "931464a16ad1144a4c9c8cc5ca58548ed365e24f";//小米
            token = "2de820afa4853e70c735c3e1325a07b430110375";//华为
            //token = "094983a3ee98a0f7e27355326b83174aad9f3254";//vivo
            //token = "205445ada5b50439419190658ea650e0f8895543";//魅族

            Message message = new Message();
            message.setType("notify");
            message.setStyle(new Style(0, 1, 1, 1, messageIndex));
            message.setTitle("title" + messageIndex);
            message.setSendTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            message.setContent("content" + messageIndex);
            message.setCustom(new Dictionary<string, object>() {
                { "custom_content",new Dictionary<string, object>() {
                { "title","title" + messageIndex},
                 { "body","content" + messageIndex},
                  { "custom","abc"},
            }}
            });


            //必须把action设置为null，否则小米无法接收点击事件
            message.setAction(null);

            XingeApp.XingeApp xinge = new XingeApp.XingeApp(appID, accessID, secretKey);
            string ret = xinge.PushSingleDevice(token, message);

        }


        [Fact]
        public void TestPushTokenOfiOS()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushTokeniOS("5412567459229", 2200262432, "24f595178abda55aa74dc2ce4033d600", "CSharpSDK " + messageIndex,"1043b93f56334bf010d40ccefa1244d8557a45161d55ff3ecbb7e1b13e192f65", XingeApp.XingeApp.PushEnvironmentofiOS.develop);
            Console.WriteLine(result);
        }
        [Fact]
        public void TestPushTokenOfAndroid()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushTokenAndroid("d617a675b62d0",2100271539, "9e05364c6d56da943783e61da091e8e5","Android","CSharpSDK " + messageIndex, "9579bab6e7d7533f70e8e0be2e45d01fe1b88b2f");
            Console.WriteLine(result);
        }
        [Fact]
        public void TestPushAccountOfiOS()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushAccountiOS("5412567459229", 2200262432, "24f595178abda55aa74dc2ce4033d600", "CSharpSDK " + messageIndex,"your test account", XingeApp.XingeApp.PushEnvironmentofiOS.develop);
            Console.WriteLine(result);
        }
        [Fact]
        public void TestPushAccountOfAndroid()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushAccountAndroid("d617a675b62d0",2100271539, "9e05364c6d56da943783e61da091e8e5","Android","CSharpSDK " + messageIndex, "your test account");
            Console.WriteLine(result);
        }
        [Fact]
        public void TestPushTagOfiOS()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushTagiOS("5412567459229", 2200262432, "24f595178abda55aa74dc2ce4033d600", "CSharpSDK " + messageIndex,"your_test_tag", XingeApp.XingeApp.PushEnvironmentofiOS.develop);
            Console.WriteLine(result);
        }
        
        [Fact]
        public void TestPushTagOfAndroid()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushTagAndroid("d617a675b62d0",2100271539, "9e05364c6d56da943783e61da091e8e5","Android","CSharpSDK " + messageIndex, "your_test_tag");
            Console.WriteLine(result);
        }
        
        [Fact]
        public void TestPushAllOfiOS()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushAlliOS("5412567459229", 2200262432, "24f595178abda55aa74dc2ce4033d600", "CSharpSDK " + messageIndex, XingeApp.XingeApp.PushEnvironmentofiOS.develop);
            Console.WriteLine(result);
        }
        [Fact]
        public void TestPushAllOfAndroid()
        {
            string result = null;
            Random random = new Random();
            int messageIndex = random.Next(9999);
            result = XingeApp.XingeApp.pushAllAndroid("d617a675b62d0",2100271539, "9e05364c6d56da943783e61da091e8e5","Android","CSharpSDK"+ messageIndex);
            Console.WriteLine(result);
        }

    }
}
