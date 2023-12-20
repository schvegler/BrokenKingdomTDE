﻿#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





extern void VideoClipPlayable_GetHandle_m1D990903234220E9FE756F2DA895650EBDC1415D (void);
extern void VideoClipPlayable_Equals_mDBA2CCE1368B628829B065EA8DEDE84512B2723E (void);
extern void VideoPlayer_Prepare_mC0EF4CC2E5A6B7C04F9F810DD9406A6146BEE6EA (void);
extern void VideoPlayer_Play_m8E99607F39F1D214BDD704F3E130DD2418787ACE (void);
extern void VideoPlayer_Pause_m1975BF6BEE27064602EEB8191C963888CF5B226E (void);
extern void VideoPlayer_Stop_m1F2DE73183E042998140A56FF69432A200430BF1 (void);
extern void VideoPlayer_get_isPlaying_mC4CCA87F909A3A14209D632D16D7C8FC34F01520 (void);
extern void VideoPlayer_get_frame_m57EC801B265F40B3D4AB73BE1F1C42EB6B77988A (void);
extern void VideoPlayer_set_frame_mDD1CBF9BD07C3720DC8B1798CE434BAD5B75803B (void);
extern void VideoPlayer_StepForward_m33AD97E2C078C7BF769C73BA2432DBD05EE2EA1D (void);
extern void VideoPlayer_set_playbackSpeed_mD57C135A94C988D209390B879D84464A13CB91FD (void);
extern void VideoPlayer_get_isLooping_m9E4671C5136760DDD572FFF425B48B56DC7C3B8B (void);
extern void VideoPlayer_set_isLooping_m37563E7D24110FDBBBB4E48EA90E639BE778264E (void);
extern void VideoPlayer_SetDirectAudioVolume_m77236AFF5D3EB228B22C41B4A31C3C5DC72A8BE8 (void);
extern void VideoPlayer_SetDirectAudioMute_mA22511B44579744FD391D6EF2DC5C75A3AF97E8A (void);
extern void VideoPlayer_InvokePrepareCompletedCallback_Internal_mF483B141E9AF0B553FF87B32A0EE54E40BE21EFD (void);
extern void VideoPlayer_InvokeFrameReadyCallback_Internal_mF5F02FE6BBEA70C62108F3FD836E1B378CB9F5E7 (void);
extern void VideoPlayer_InvokeLoopPointReachedCallback_Internal_m090FD00BB12721EB3CEB337E30687D5DE6B1EBD6 (void);
extern void VideoPlayer_InvokeStartedCallback_Internal_mBDD186C95E57DD264CD0957FA46D9F65728C67EF (void);
extern void VideoPlayer_InvokeFrameDroppedCallback_Internal_m6E6B6353404AF76AB16D1433B8553659B0744DC0 (void);
extern void VideoPlayer_InvokeErrorReceivedCallback_Internal_m91E59ED70189824AB2C5D0AEB47742130EE98574 (void);
extern void VideoPlayer_InvokeSeekCompletedCallback_Internal_m62AEB9826ACE95B88CC60220375C1C7EF5EEEE1F (void);
extern void VideoPlayer_InvokeClockResyncOccurredCallback_Internal_m743B8421E9538761141364EBDCEBC673BA58D8C6 (void);
extern void EventHandler__ctor_mFCF62E0BB29DD3D2B2F1306BD8657E374CF60903 (void);
extern void EventHandler_Invoke_m8A3288B6DF1FE2699A58EA22D0B830BB20E94E15 (void);
extern void ErrorEventHandler__ctor_m78073CD72C64AAFAF54A01702919A847185F4C58 (void);
extern void ErrorEventHandler_Invoke_m0601D855B85F5053A0A10A0166A8CE469D4672C5 (void);
extern void FrameReadyEventHandler__ctor_mD875F736BCA2A2128427AB0546B5081ED3B22D56 (void);
extern void FrameReadyEventHandler_Invoke_m73FF71F81A620194421226D8A98C64FB82E7B235 (void);
extern void TimeEventHandler__ctor_m7BF78A616C8FF71B3A7CA62B1A03446A5C581309 (void);
extern void TimeEventHandler_Invoke_m2327761543815FB7181FFF73E87FC5EC0F84349D (void);
static Il2CppMethodPointer s_methodPointers[31] = 
{
	VideoClipPlayable_GetHandle_m1D990903234220E9FE756F2DA895650EBDC1415D,
	VideoClipPlayable_Equals_mDBA2CCE1368B628829B065EA8DEDE84512B2723E,
	VideoPlayer_Prepare_mC0EF4CC2E5A6B7C04F9F810DD9406A6146BEE6EA,
	VideoPlayer_Play_m8E99607F39F1D214BDD704F3E130DD2418787ACE,
	VideoPlayer_Pause_m1975BF6BEE27064602EEB8191C963888CF5B226E,
	VideoPlayer_Stop_m1F2DE73183E042998140A56FF69432A200430BF1,
	VideoPlayer_get_isPlaying_mC4CCA87F909A3A14209D632D16D7C8FC34F01520,
	VideoPlayer_get_frame_m57EC801B265F40B3D4AB73BE1F1C42EB6B77988A,
	VideoPlayer_set_frame_mDD1CBF9BD07C3720DC8B1798CE434BAD5B75803B,
	VideoPlayer_StepForward_m33AD97E2C078C7BF769C73BA2432DBD05EE2EA1D,
	VideoPlayer_set_playbackSpeed_mD57C135A94C988D209390B879D84464A13CB91FD,
	VideoPlayer_get_isLooping_m9E4671C5136760DDD572FFF425B48B56DC7C3B8B,
	VideoPlayer_set_isLooping_m37563E7D24110FDBBBB4E48EA90E639BE778264E,
	VideoPlayer_SetDirectAudioVolume_m77236AFF5D3EB228B22C41B4A31C3C5DC72A8BE8,
	VideoPlayer_SetDirectAudioMute_mA22511B44579744FD391D6EF2DC5C75A3AF97E8A,
	VideoPlayer_InvokePrepareCompletedCallback_Internal_mF483B141E9AF0B553FF87B32A0EE54E40BE21EFD,
	VideoPlayer_InvokeFrameReadyCallback_Internal_mF5F02FE6BBEA70C62108F3FD836E1B378CB9F5E7,
	VideoPlayer_InvokeLoopPointReachedCallback_Internal_m090FD00BB12721EB3CEB337E30687D5DE6B1EBD6,
	VideoPlayer_InvokeStartedCallback_Internal_mBDD186C95E57DD264CD0957FA46D9F65728C67EF,
	VideoPlayer_InvokeFrameDroppedCallback_Internal_m6E6B6353404AF76AB16D1433B8553659B0744DC0,
	VideoPlayer_InvokeErrorReceivedCallback_Internal_m91E59ED70189824AB2C5D0AEB47742130EE98574,
	VideoPlayer_InvokeSeekCompletedCallback_Internal_m62AEB9826ACE95B88CC60220375C1C7EF5EEEE1F,
	VideoPlayer_InvokeClockResyncOccurredCallback_Internal_m743B8421E9538761141364EBDCEBC673BA58D8C6,
	EventHandler__ctor_mFCF62E0BB29DD3D2B2F1306BD8657E374CF60903,
	EventHandler_Invoke_m8A3288B6DF1FE2699A58EA22D0B830BB20E94E15,
	ErrorEventHandler__ctor_m78073CD72C64AAFAF54A01702919A847185F4C58,
	ErrorEventHandler_Invoke_m0601D855B85F5053A0A10A0166A8CE469D4672C5,
	FrameReadyEventHandler__ctor_mD875F736BCA2A2128427AB0546B5081ED3B22D56,
	FrameReadyEventHandler_Invoke_m73FF71F81A620194421226D8A98C64FB82E7B235,
	TimeEventHandler__ctor_m7BF78A616C8FF71B3A7CA62B1A03446A5C581309,
	TimeEventHandler_Invoke_m2327761543815FB7181FFF73E87FC5EC0F84349D,
};
extern void VideoClipPlayable_GetHandle_m1D990903234220E9FE756F2DA895650EBDC1415D_AdjustorThunk (void);
extern void VideoClipPlayable_Equals_mDBA2CCE1368B628829B065EA8DEDE84512B2723E_AdjustorThunk (void);
static Il2CppTokenAdjustorThunkPair s_adjustorThunks[2] = 
{
	{ 0x06000001, VideoClipPlayable_GetHandle_m1D990903234220E9FE756F2DA895650EBDC1415D_AdjustorThunk },
	{ 0x06000002, VideoClipPlayable_Equals_mDBA2CCE1368B628829B065EA8DEDE84512B2723E_AdjustorThunk },
};
static const int32_t s_InvokerIndices[31] = 
{
	5575,
	3448,
	5677,
	5677,
	5677,
	5677,
	5472,
	5533,
	4556,
	5677,
	4638,
	5472,
	4496,
	2683,
	2681,
	8276,
	7727,
	8276,
	8276,
	8276,
	7733,
	8276,
	7723,
	2616,
	4604,
	2616,
	2619,
	2616,
	2615,
	2616,
	2612,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_VideoModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_VideoModule_CodeGenModule = 
{
	"UnityEngine.VideoModule.dll",
	31,
	s_methodPointers,
	2,
	s_adjustorThunks,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
