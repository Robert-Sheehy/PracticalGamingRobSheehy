using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void apply_damage(int damage_amount);

    bool has_died();
}
