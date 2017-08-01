class IntPtr {
    private System.IntPtr _intPtr;

    public IntPtr(System.IntPtr intPtr) => _intPtr = intPtr;
    public IntPtr(long i) => _intPtr = new System.IntPtr(i);

    public System.IntPtr Value => _intPtr;
    public static IntPtr Zero => new IntPtr(System.IntPtr.Zero);

    public static implicit operator IntPtr(long i) => new IntPtr(new System.IntPtr(i));
    public static implicit operator System.IntPtr(IntPtr i) => i.Value;
    public static implicit operator IntPtr(System.IntPtr i) => new IntPtr(i);

    public static IntPtr operator +(IntPtr _this, IntPtr _that) => _this.Add(_that.Value.ToInt64());
    public static IntPtr operator +(IntPtr _this, long offset) => _this.Add(offset);
    public IntPtr Add(long offset) => (_intPtr = new System.IntPtr(_intPtr.ToInt64() + offset));

    public static IntPtr operator -(IntPtr _this, IntPtr _that) => _this.Substract(_that.Value.ToInt64());
    public static IntPtr operator -(IntPtr _this, long offset) => _this.Substract(offset);
    public IntPtr Substract(long offset) => (_intPtr = new System.IntPtr(_intPtr.ToInt64() - offset));

    public static bool operator ==(IntPtr _this, IntPtr _that) => _this.Value == _that.Value;
    public static bool operator !=(IntPtr _this, IntPtr _that) => _this.Value != _that.Value;

    public long ToInt64(IntPtr _this) => _this.Value.ToInt64();
    public int ToInt32(IntPtr _this) => _this.Value.ToInt32();
    public int GetHashCode(IntPtr _this) => _this.Value.GetHashCode();
    public string ToString(IntPtr _this) => _this.Value.ToString();
    public string ToString(IntPtr _this, string s) => _this.Value.ToString(s);

    public override bool Equals(object obj) => Value.Equals(obj);
    public override int GetHashCode() => GetHashCode(Value);

    unsafe void* ToPointer(IntPtr _this) => _this.Value.ToPointer();
}
