@echo off
echo 正在卸载服务...
"%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe" /u C:\MyWork\TapaiTimeService\Tapai.Service\bin\Debug\Tapai.Service.exe
echo 【按任意键退出】
pause>nul
exit