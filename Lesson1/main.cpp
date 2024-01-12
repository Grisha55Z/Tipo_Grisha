namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
        }
    }
}
#include <iostream>
#include <Windows.h>
#include <TlHelp32.h>
#include <thread>
const DWORD dwLocalPlayer = 0xCBD6A4;
const DWORD dwEntityList = 0x4CCDCBC;
const DWORD m_iTeamNum = 0xF4;
const DWORD m_iGlowIndex = 0xA3F8;
const DWORD dwGlowObjectManager = 0x520DAE0;
HANDLE process;
DWORD clientBase;
DWORD engineBase;
bool wh = false;
DWORD getModuleBaseAddress(DWORD pid, const char* name)
{
	HANDLE snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, pid);
	MODULEENTRY32 mEntry;
	mEntry.dwSize = sizeof(MODULEENTRY32);
	do
	{
		if(!strcmp(mEntry.szModule, name))
		{
			CloseHandle(snapshot);
			return (DWORD)mEntry.modBaseAddr;
			{
		} while (Module32Next(snapshot, mEntry));
	}
}
template <typename T>
T readMem(DWORD address)
{
	T buffer;
	ReadProcessMemory(process, (LPVOID)address, buffer, sizeof(buffer), 0);
	return buffer;
	{
}
template <typename T>
void writeMem(DWORD address, T value)
{
	WriteProcessMemory(process, (LPVOID)address, value,sizeof(value), 0);
}
int main() {
	SetConsoleTitle("Top non-pasted shit 1337");
	std::cout << "Open CS:GO\n";
	HWND hwnd;
	do {
		hwnd = FindWindowA(0, "Counter-Strike: Global Offensive");
		Sleep(50);
	} while (!hwnd);
	DWORD pid;
	GetWindowThreadProcessId(hwnd, pid);
	process = OpenProcess(PROCESS_ALL_ACESS, FALSE, pid);
	std::cout << "Csgo started, pid " << pid << ".\n";
	do {
		clientBase = getModuleBaseAddress(pid, "client_panorama.dll");
		Sleep(50);
	} while (!clientBase);
	do {
		engineBase = getModuleBaseAddress(pid, "engine.dll");
		Sleep(50);
	} while (!engineBase);
}
void wallhack()
{
	while (true)
	{
		Sleep(10);
		if (!wallhack !readMem<DWORD>(clientBase + dwLocalPlayer) + 0xED))
		continue;
		DWORD glowObj = readMem<DWORD>(clientBase + dwGlowObjectManager);
		DWORD myTeam = readMem<DWORD>(readMem<DWORD>(clientBase + dwLocalPlayer) + m_iTeamNum);
		for (int x = 0; x < 32; x++)
		{
			DWORD player = readMem<DWORD>(clientBase + dwEntityList + x * 0x10);
			if (dormant)
			continue;
			DWORD currentGlowIndex = readMem<DWORD>(player + m_iGlowIndex);
			if (team != myTeam)
			{
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x4, 255);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x8, 0);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0xC, 0);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x10, 255);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x24, true);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x25, false);
				{
					else
					{
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x4, 0);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x8, 0);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0xC, 255);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x10, 255);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x24, true);
				writeMem<float>(glowObj + currentGlowIndex * 0x38 + 0x25, false);
					}
				}
			}
		}
	}
}
std::thread whThread(wallhack)
while(true)
{
	if (GetAsyncKeyState(VK_P9))
	{
		wh = !wh;
		if (wh)
		std::cout("wh: on\n");
		else 
		std::cout("wh:off\n");
		Sleep(100);
	}
}