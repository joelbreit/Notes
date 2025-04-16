#include <initializer_list>
#include <stdexcept>
#include <iterator>

template <typename T>
class MyVector {
private:
    T* data_;
    std::size_t size_;
    std::size_t capacity_;

public:
    // Constructors & Destructor
    MyVector();
    explicit MyVector(std::size_t size);
    MyVector(std::initializer_list<T> init);
    MyVector(const MyVector& other);
    MyVector(MyVector&& other) noexcept;
    ~MyVector();

    // Operator Overloads
    MyVector& operator=(const MyVector& other);
    MyVector& operator=(MyVector&& other) noexcept;
    T& operator[](std::size_t index);
    const T& operator[](std::size_t index) const;
    bool operator==(const MyVector& other) const;

    // Capacity Methods
    std::size_t size() const noexcept;
    std::size_t capacity() const noexcept;
    bool empty() const noexcept;
    void reserve(std::size_t new_capacity);
    void shrink_to_fit();

    // Modifiers
    void push_back(const T& value);
    void push_back(T&& value);
    void pop_back();
    void clear();
    void resize(std::size_t new_size);
    void insert(std::size_t index, const T& value);
    void erase(std::size_t index);

    // Data Access
    T& at(std::size_t index);
    const T& at(std::size_t index) const;
    T& front();
    const T& front() const;
    T& back();
    const T& back() const;
    T* data();
    const T* data() const;

    // Iterators
    class Iterator {
    private:
        T* ptr_;
    public:
        using iterator_category = std::random_access_iterator_tag;
        using value_type = T;
        using difference_type = std::ptrdiff_t;
        using pointer = T*;
        using reference = T&;

        Iterator(T* ptr);
        Iterator& operator++();
        Iterator operator++(int);
        Iterator& operator--();
        Iterator operator--(int);
        T& operator*();
        bool operator==(const Iterator& other) const;
        bool operator!=(const Iterator& other) const;
    };

    Iterator begin();
    Iterator end();
};
