using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 10f;
    public float fireInterval = 2.5f;
    public float deadZone = 9f;

    private float lastFireTime;

    private void Start()
    {
        lastFireTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - lastFireTime >= fireInterval)
        {
            LaunchProjectile();
            lastFireTime = Time.time;
        }
    }

    private void LaunchProjectile()
    {
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D projectileRigidbody = newProjectile.GetComponent<Rigidbody2D>();
        
        transform.position = transform.position + (Vector3.left * projectileSpeed) * Time.deltaTime;

        if (projectileRigidbody != null)
        {
            projectileRigidbody.velocity = firePoint.right * projectileSpeed;
        }
        else
        {
            Debug.LogWarning("Projectile prefab does not have a Rigidbody2D component.");
        }

    }
}
