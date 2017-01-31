#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.ParticleSystem
struct ParticleSystem_t3394631041;
// UnityEngine.Camera
struct Camera_t189460977;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ClickEffect
struct  ClickEffect_t164705807  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.ParticleSystem ClickEffect::tapEffect
	ParticleSystem_t3394631041 * ___tapEffect_2;
	// UnityEngine.Camera ClickEffect::_camera
	Camera_t189460977 * ____camera_3;

public:
	inline static int32_t get_offset_of_tapEffect_2() { return static_cast<int32_t>(offsetof(ClickEffect_t164705807, ___tapEffect_2)); }
	inline ParticleSystem_t3394631041 * get_tapEffect_2() const { return ___tapEffect_2; }
	inline ParticleSystem_t3394631041 ** get_address_of_tapEffect_2() { return &___tapEffect_2; }
	inline void set_tapEffect_2(ParticleSystem_t3394631041 * value)
	{
		___tapEffect_2 = value;
		Il2CppCodeGenWriteBarrier(&___tapEffect_2, value);
	}

	inline static int32_t get_offset_of__camera_3() { return static_cast<int32_t>(offsetof(ClickEffect_t164705807, ____camera_3)); }
	inline Camera_t189460977 * get__camera_3() const { return ____camera_3; }
	inline Camera_t189460977 ** get_address_of__camera_3() { return &____camera_3; }
	inline void set__camera_3(Camera_t189460977 * value)
	{
		____camera_3 = value;
		Il2CppCodeGenWriteBarrier(&____camera_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
