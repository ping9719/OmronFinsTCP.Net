# POmronFinsTCP.Net

### 欧姆龙plc通信FINS协议的实现。此项目是OmronFinsTCP.Net的分支。
##### This is a protocol for communicating with Omron PLCs. 
#

### 拷贝的原项目：[Copy to：]
### https://github.com/iHomeSoft/OmronFinsTCP.Net
#

### 下载包 [download、install]
```CSharp
Install-Package POmronFinsTCP.Net
```
#

### 列子:[ensample code:]
```CSharp
FinsDebuger/Form1.cs
```
#

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

#### 泛型方式：读/写 [Use T:read/write]
```CSharp
/*T支持的类型为：int16,int32,bool,float*/
ENT.GetData<T>();//读一个数据
ENT.SetData<T>();//写一个数据

//未来可能推出... [being developed...]
ENT.GetDatas<T>();//读多个数据
ENT.SetDatas<T>();//写多个数据
```

#
### 版本记录：[version history]
###### *表示部分代码可能与前版本不兼容 [*For some code is incompatible with previous versions]
## v3.1.1
###### 1.优化GetData错误处理和效率问题 [Optimize GetData]
## v3.1.0
###### 1.支持泛型读写单个 [Add GetData\<T>(),SetData\<T>()]
## v3.0.2
###### 1.修复写单个浮点BUG [Amend WriteReal()]
###### 2.支持读写Int32 [Add ReadInt32(),WriteInt32()]
###### 3.读写重载对字符串解析的支持，如'D100;W100.1' [Read/write overloading support for string parsing]
## v3.0.1
###### 1.支持写单个浮点 [Add WriteReal()]
## v3.0.0
###### 1.拷贝项目，并升级到新的Net支持 [Copy project,New Net support]

