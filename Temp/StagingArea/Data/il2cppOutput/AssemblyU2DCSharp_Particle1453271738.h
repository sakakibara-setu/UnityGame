#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Particle
struct  Particle_t1453271738  : public MonoBehaviour_t1158329972
{
public:

public:
};

struct Particle_t1453271738_StaticFields
{
public:
	// UnityEngine.GameObject Particle::_prefab
	GameObject_t1756533147 * ____prefab_2;

public:
	inline static int32_t get_offset_of__prefab_2() { return static_cast<int32_t>(offsetof(Particle_t1453271738_StaticFields, ____prefab_2)); }
	inline GameObject_t1756533147 * get__prefab_2() const { return ____prefab_2; }
	inline GameObject_t1756533147 ** get_address_of__prefab_2() { return &____prefab_2; }
	inline void set__prefab_2(GameObject_t1756533147 * value)
	{
		____prefab_2 = value;
		Il2CppCodeGenWriteBarrier(&____prefab_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
