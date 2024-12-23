# POmronFinsTCP.Net

### 欧姆龙plc通信FINS协议的实现。此项目是OmronFinsTCP.Net的分支。
##### This is a protocol for communicating with Omron PLCs. 
#

### 拷贝的原项目：[Copy to：]
### https://github.com/iHomeSoft/OmronFinsTCP.Net

### 下载包 [download、install]
```CSharp
Install-Package POmronFinsTCP.Net
```

### 开始使用 [How To Use]
#### 连接 [connect]
```CSharp
using OmronFinsTCP.Net;

EtherNetPLC ENT = new EtherNetPLC();
short re = ENT.Link("192.168.1.100", 9600)
if (re == 0)
    Console.WriteLine("ok");
else
    Console.WriteLine("err");
```
#### 泛型方式：读/写 [Use T:read/write]
```CSharp
//T支持的类型为：int16,int32,bool,float
ENT.GetData<T>();//读一个数据
ENT.SetData<T>();//写一个数据
ENT.GetDatas<T>();//读多个数据
ENT.SetDatas<T>();//写多个数据
```

#### 普通方式：读/写 [read/write]
```CSharp
/*所有方法返回0为成功*/
ENT.ReadWord();//读单个Int16
ENT.ReadWords();//读多个Int16
ENT.WriteWord();//写单个Int16
ENT.WriteWords();//写多个Int16
ENT.GetBitState();//读单个位
ENT.SetBitState();//写单个位
ENT.ReadReal();//读单个浮点
ENT.WriteReal();//写单个浮点
ENT.ReadInt32();//读单个Int32
ENT.WriteInt32();//写单个Int32
```


#
### 版本记录：[version history]
###### *表示部分代码可能与前版本不兼容 [*For some code is incompatible with previous versions]
### v3.3.1
###### 1.构造函数增加默认端口 [Default port]
### v3.3.0
###### 1.增加CNT、TIM的读取。感谢@[茁]研小艾 [Add read CNT、TIM]
###### 2.优化连续读取的一些效率 [Optimized reading efficiency]
### v3.2.2*
###### 1.SetData错误处理改为抛出异常 [The 'SetData()' error is throwing an exception]
### v3.2.1
###### 1.没有连接时错误优化 [No connection error handling]
### v3.2.0
###### 1.支持连接到多个PLC [Supports connection to multiple PLCS]
### v3.1.2
###### 1.泛型支持多个读写 [Generics support multiple reads and writes]
###### 2.修复SetData无效问题 [Fix SetData\<T>()]
### v3.1.1
###### 1.优化GetData错误处理和效率问题 [Optimize GetData]
### v3.1.0
###### 1.支持泛型读写单个 [Add GetData\<T>(),SetData\<T>()]
### v3.0.2
###### 1.修复写单个浮点BUG [Amend WriteReal()]
###### 2.支持读写Int32 [Add ReadInt32(),WriteInt32()]
###### 3.读写重载对字符串解析的支持，如'D100;W100.1' [Read/write overloading support for string parsing]
### v3.0.1
###### 1.支持写单个浮点 [Add WriteReal()]
### v3.0.0
###### 1.拷贝项目，并升级到新的Net支持 [Copy project,New Net support]

