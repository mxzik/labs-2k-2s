
// 1labView.h: интерфейс класса CMy1labView
//

#pragma once


class CMy1labView : public CView
{
protected: // создать только из сериализации
	CMy1labView() noexcept;
	DECLARE_DYNCREATE(CMy1labView)

// Атрибуты
public:
	CMy1labDoc* GetDocument() const;

// Операции
public:

// Переопределение
public:
	virtual void OnDraw(CDC* pDC);  // переопределено для отрисовки этого представления
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// Реализация
public:
	virtual ~CMy1labView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Созданные функции схемы сообщений
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // версия отладки в 1labView.cpp
inline CMy1labDoc* CMy1labView::GetDocument() const
   { return reinterpret_cast<CMy1labDoc*>(m_pDocument); }
#endif

