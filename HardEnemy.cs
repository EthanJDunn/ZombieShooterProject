using UnityEngine;

public class HardEnemy : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Player _player;
    private float _speed;

    public float BaseSpeed;
    public GameObject Blood;

    public int maxHealth = 20;

    public int currentHealth;

    public EnemyHealth eHealthBar;
    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _speed = BaseSpeed * (1 + Random.Range(-0.1f, 0.1f));
        _player = FindObjectOfType<Player>();
        currentHealth = maxHealth;
       // eHealthBar.SetMaxHealth(maxHealth);
        
    }
    
    void Update()
    {
        if (_player != null)
        {
            transform.up = (_player.transform.position - transform.position).normalized;
            _rigidbody.velocity = transform.up * _speed;
        }
         if (currentHealth <= 0)
        {      
            Instantiate(Blood, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        TakeDamage(1);
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //eHealthBar.SetHealth(currentHealth);

        Destroy(gameObject);
    }
}
