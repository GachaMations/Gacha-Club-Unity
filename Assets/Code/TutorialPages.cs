using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TutorialPages : MonoBehaviour
{
    public Sprite Page1;
    public Sprite Page2;
    public Sprite Page3;
    public Sprite Page4;
    public Sprite Page5;
    public Sprite Page6;
    private int CurPage;
    SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        CurPage = 1;
    }

    void Update()
    {
        if(CurPage == 1)
        {
            m_SpriteRenderer.sprite = Page1;
        }
        if(CurPage == 2)
        {
            m_SpriteRenderer.sprite = Page2;
        }
        if(CurPage == 3)
        {
            m_SpriteRenderer.sprite = Page3;
        }
        if(CurPage == 4)
        {
            m_SpriteRenderer.sprite = Page4;
        }
        if(CurPage == 5)
        {
            m_SpriteRenderer.sprite = Page5;
        }
        if(CurPage == 6)
        {
            m_SpriteRenderer.sprite = Page6;
        }
    }

    public void PageForward()
    {
        if(CurPage == 1)
        {
            CurPage = 2;
            return;
        }
        if(CurPage == 2)
        {
            CurPage = 3;
            return;

        }
        if(CurPage == 3)
        {
            CurPage = 4;
            return;

        }
        if(CurPage == 4)
        {
            CurPage = 5;
            return;
        }
        if(CurPage == 5)
        {
            CurPage = 6;
            return;
        }
        if(CurPage == 6)
        {
            CurPage = 1;
            return;
        }
    }

    public void PageBackwards()
    {
        if(CurPage == 1)
        {
            CurPage = 6;
            return;
        }
        if(CurPage == 2)
        {
            CurPage = 1;
            return;

        }
        if(CurPage == 3)
        {
            CurPage = 2;
            return;

        }
        if(CurPage == 4)
        {
            CurPage = 3;
            return;
        }
        if(CurPage == 5)
        {
            CurPage = 4;
            return;
        }
        if(CurPage == 6)
        {
            CurPage = 5;
            return;
        }
    }
    public void pg1()
    {
        CurPage = 1;
    }
    public void pg2()
    {
        CurPage = 2;
    }
    public void pg3()
    {
        CurPage = 3;
    }
    public void pg4()
    {
        CurPage = 4;
    }
    public void pg5()
    {
        CurPage = 5;
    }
    public void pg6()
    {
        CurPage = 6;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }






}

