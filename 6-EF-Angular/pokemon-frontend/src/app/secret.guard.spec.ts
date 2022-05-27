import { TestBed } from '@angular/core/testing';

import { SecretGuard } from './secret.guard';

describe('SecretGuard', () => {
  let guard: SecretGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(SecretGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
