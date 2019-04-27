﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClient
{
	//存放bundle的路径
	string GetDataPath();
	//存放lua脚本的路径
	string GetLuaPath();
	//持久化路径
	string GetPersisdentPath();
	//本地md5文件存放路径
	string GetPersisdentMD5File();
	//本地存放服务器最新md5的路径
	string GetPersisdentServerMD5File();
	//要下载的MD5文件名
	string GetHttpServerMD5();
	//资源依赖文件
	string GetResDependFile();
	//要下载的资源包的目录
	string GetHttpServerBundleDir();
	//本地log目录
	string GetLogPath();
	//streaming文件目录
	string GetStreamingDataPath();
	//streaming md5文件
	string GetStreamingMD5File();
}