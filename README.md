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
short re = ENT.Link("192.168.1.100", 9600);
if (re == 0)
    Console.WriteLine("ok");
else
    Console.WriteLine("err");
```

#### 读/写 [read/write]
```CSharp
ENT.ReadWord();//读单个
ENT.ReadWords();//读多个
ENT.WriteWord();//写单个
ENT.WriteWords();//写多个
ENT.GetBitState();//读单个位
ENT.SetBitState();//写单个位
ENT.ReadReal();//读单个浮点
ENT.WriteReal();//写单个浮点
```
#
### 版本记录：[version history]
###### *表示部分代码可能与前版本不兼容 [*For some code is incompatible with previous versions]
## v3.0.1
###### 1.支持写单个浮点 [Add WriteReal()]
## v3.0.0
###### 1.拷贝项目，并升级到新的Net支持 [Copy project,New Net support]

