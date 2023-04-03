

class Account {
    
  Acc_no: number;
  Balance: number;

  constructor(acc_no: number, balance: number) {
    this.Acc_no = acc_no;
    this.Balance = balance;
  }

  getBalance(): number {
    return this.Balance;
  }

  creditAmount(amount: number): void {
    //Logic
  }

  debitAmount(amount: number): void {
    //Logic
  }
}


interface IAccount {
  DateOfOpening: Date;
  addCustomer(): void;
  removeCustomer(): void;
}



class Current_Account extends Account implements IAccount {
  DateOfOpening: Date;

  constructor(acc_no: number, balance: number, dateOfOpening: Date) {
    super(acc_no, balance);
    this.DateOfOpening = dateOfOpening;
  }

  addCustomer(): void {
    
  }

  removeCustomer(): void {
    
  }
}

class Saving_Account extends Account implements IAccount {
  DateOfOpening: Date;

  constructor(acc_no: number, balance: number, dateOfOpening: Date) {
    super(acc_no, balance);
    this.DateOfOpening = dateOfOpening;
  }

  addCustomer(): void {
    
  }

  removeCustomer(): void {
   
  }
}
